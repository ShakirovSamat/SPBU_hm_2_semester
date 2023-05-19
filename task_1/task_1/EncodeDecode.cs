namespace program
{
    public static class EncodeDecode
    {
        //encodes bytes
        public static (byte[], double) Encode(byte[] bytes)
        {
            byte count = 1;
            int index = 0;
            byte[] temporary = new byte[bytes.Length * 2];
            //runs through whole bytes
            for (int i = 1; i < bytes.Length; ++i)
            {
                //if nearby bytes  are the same
                if (bytes[i - 1] == bytes[i])
                {
                    ++count;
                    // the situation when amount of same bytes more than bytes capacity
                    if (count == 255)
                    {
                        temporary[index] = count;
                        temporary[index + 1] = bytes[i - 1];
                        index = index + 2;
                        count = 1;
                        i = i + 1;
                    }
                }
                // if nearby bytes are different
                else
                {
                    temporary[index] = count;
                    temporary[index + 1] = bytes[i - 1];
                    index = index + 2;
                    count = 1;
                }
            }
            //processes last byte
            temporary[index] = count;
            temporary[index + 1] = bytes[bytes.Length - 1];

            //writes bytes to suitable for size array
            byte[] encoded = new byte[index + 2];
            for (int i = 0; i < index + 2; ++i)
            {
                encoded[i] = temporary[i];
            }

            //compression ratio
            double d = (double)index / (double)bytes.Length;

            return (encoded, d);
        }

        //deecodes bytes
        public static byte[] Decode(byte[] bytes)
        {
            //gets length of decoded array
            int length = 0;
            for (int i = 0; i < bytes.Length; i += 2)
            {
                length += bytes[i];
            }

            //decodes
            int index = 0;
            byte[] decoded = new byte[length];
            for (int i = 0; i < bytes.Length; i += 2)
            {
                for (int j = 0; j < bytes[i]; ++j)
                {
                    decoded[index] = bytes[i + 1];
                    ++index;
                }
            }

            return decoded;
        }
    }
}
