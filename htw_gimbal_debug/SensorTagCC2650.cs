using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace htw_gimbal_debug
{

    /*
    0x21	33	0xAA01	IR Temperature Data
    0x29	41	0xAA21	Humidity Data
    0x31	49	0xAA41	Barometer Data
    0x39	57	0xAA81	Movement Data
    0x41	65	0xAA71	Luxometer Data
    */
    public enum TI_Sensor_Data
    {
        Temperature = 0x21,
        Humidity = 0x29,
        Barometer = 0x31,
        Movement = 0x39,
        Luxometer = 0x41
    }

    public struct Point3D
    {
        public double x;
        public double y;
        public double z;

        public Point3D(double X, double Y, double Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }
    }

    public class SensorTagCC2650
    {
        public double getTempAmbient(byte[] buf)
        {
            return BitConverter.ToUInt16(buf, 2) / 128.0;
        }

        public double extractTargetTemperature(byte[] v, double ambient)
        {
            int twoByteValue = BitConverter.ToInt16(v, 0);

            double Vobj2 = twoByteValue;
            Vobj2 *= 0.00000015625;

            double Tdie = ambient + 273.15;

            double S0 = 5.593E-14; // Calibration factor
            double a1 = 1.75E-3;
            double a2 = -1.678E-5;
            double b0 = -2.94E-5;
            double b1 = -5.7E-7;
            double b2 = 4.63E-9;
            double c2 = 13.4;
            double Tref = 298.15;
            double S = S0 * (1 + a1 * (Tdie - Tref) + a2 * Math.Pow((Tdie - Tref), 2));
            double Vos = b0 + b1 * (Tdie - Tref) + b2 * Math.Pow((Tdie - Tref), 2);
            double fObj = (Vobj2 - Vos) + c2 * Math.Pow((Vobj2 - Vos), 2);
            double tObj = Math.Pow(Math.Pow(Tdie, 4) + (fObj / S), .25) - 273.15;

            return (tObj - 32) * 5.0 / 9.0;
        }

        public double convertHumidity(byte[] value)
        {
            int a = BitConverter.ToUInt16(value, 2);
            // bits [1..0] are status bits and need to be cleared according
            // to the user guide, but the iOS code doesn't bother. It should
            // have minimal impact.
            a = a - (a % 4);
            return (-6f) + 125f * (a / 65535f);
        }

        public double convertBarometer(byte[] value)
        {
            int mantissa;
            int exponent;
            int sfloat = BitConverter.ToUInt16(value, 2);

            mantissa = sfloat & 0x0FFF;
            exponent = (sfloat >> 12) & 0xFF;

            double output;
            double magnitude = Math.Pow(2.0f, exponent);
            output = (mantissa * magnitude);

            return output / 10000.0f;
        }

        public Point3D convertGyroscope(byte[] value)
        {
            double coeff = 2f / 32768f;

            double x = BitConverter.ToInt16(value, 0) * coeff;
            double y = BitConverter.ToInt16(value, 2) * coeff;
            double z = BitConverter.ToInt16(value, 4) * coeff;

            return new Point3D(x, y, z);
        }

        public Point3D convertGyroscopeX(byte[] value)
        {
            float y = BitConverter.ToInt16(value, 0) * (500f / 65536f) * -1;
            float x = BitConverter.ToInt16(value, 2) * (500f / 65536f);
            float z = BitConverter.ToInt16(value, 4) * (500f / 65536f);

            return new Point3D(x, y, z);
        }

        public Point3D convertAccelerometer(byte[] value)
        {
            /*
             * The accelerometer has the range [-2g, 2g] with unit (1/64)g.
             * To convert from unit (1/64)g to unit g we divide by 64.
             * (g = 9.81 m/s^2)
             * The z value is multiplied with -1 to coincide with how we have arbitrarily defined the positive y direction. (illustrated by the apps accelerometer
             * image)
             */

            // Range 8G

            value = value.Skip(6).ToArray();

            double coeff = 180f / 32768f;

            double x = BitConverter.ToInt16(value, 0) * coeff;
            double y = BitConverter.ToInt16(value, 2) * coeff;
            double z = BitConverter.ToInt16(value, 4) * coeff;

            return new Point3D(x, y, z);
        }

        double roll, pitch;

        public Point3D convertAccelerometerX(byte[] value)
        {
            /*
             * The accelerometer has the range [-2g, 2g] with unit (1/64)g.
             * To convert from unit (1/64)g to unit g we divide by 64.
             * (g = 9.81 m/s^2)
             * The z value is multiplied with -1 to coincide with how we have arbitrarily defined the positive y direction. (illustrated by the apps accelerometer
             * image)
             */

            // Range 8G
            double SCALE = 4096.0;

            value = value.Skip(6).ToArray();

            int X = (value[0] << 8) + value[1];
            int Y = (value[2] << 8) + value[3];
            int Z = (value[4] << 8) + value[5];

            return new Point3D(X / SCALE, Y / SCALE, Z / SCALE);
        }

        public Point3D mpuAccToEuler(Point3D acc)
        {
            double X = acc.x;
            double Y = acc.y;
            double Z = acc.z;

            roll = Math.Atan2(Math.Sqrt(Y * Y + X * X), Z) * 180 / Math.PI;
            pitch = Math.Atan2(Math.Sqrt(X * X + Z * Z), Y) * 180 / Math.PI;

            return new Point3D(roll, pitch, 0.0);
        }

        public Point3D convertMagnetometer(byte[] value)
        {
            //Point3D mcal = MagnetometerCalibrationCoefficients.INSTANCE.val;
            // Multiply x and y with -1 so that the values correspond with the image in the app
            value = value.Skip(12).ToArray();

            double coeff = 4912f / 32760f;

            double x = BitConverter.ToInt16(value, 0) * coeff;
            double y = BitConverter.ToInt16(value, 2) * coeff;
            double z = BitConverter.ToInt16(value, 4) * coeff;

            //return new Point3D(x - mcal.x, y - mcal.y, z - mcal.z);
            return new Point3D(x, y, z);
        }

        public Point3D convertMagnetometerX(byte[] value)
        {
            //Point3D mcal = MagnetometerCalibrationCoefficients.INSTANCE.val;
            // Multiply x and y with -1 so that the values correspond with the image in the app
            value = value.Skip(12).ToArray();

            float x = BitConverter.ToInt16(value, 0) * (2000f / 65536f) * -1;
            float y = BitConverter.ToInt16(value, 2) * (2000f / 65536f) * -1;
            float z = BitConverter.ToInt16(value, 4) * (2000f / 65536f);

            //return new Point3D(x - mcal.x, y - mcal.y, z - mcal.z);
            return new Point3D(x, y, z);
        }

        public double convertLuxometer(byte[] value)
        {
            int mantissa;
            int exponent;
            int sfloat = BitConverter.ToUInt16(value, 0);

            mantissa = sfloat & 0x0FFF;
            exponent = (sfloat >> 12) & 0xFF;

            double output;
            double magnitude = Math.Pow(2.0f, exponent);
            output = (mantissa * magnitude);

            return output / 100.0f;
        }
    }
}
