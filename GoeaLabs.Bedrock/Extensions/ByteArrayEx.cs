/*
   Copyright 2022, GoeaLabs

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */

using HWRNG = System.Security.Cryptography.RandomNumberGenerator;

namespace GoeaLabs.Bedrock.Extensions
{
    public static class ByteArrayEx
    {
        static readonly HWRNG hwRNG = HWRNG.Create();

        /// <summary>
        /// Fills <paramref name="this"/> with true random numbers.
        /// </summary>
        /// <param name="this">Itself.</param>
        /// <returns>A reference to <paramref name="this"/>.</returns>
        public static byte[] FillRandom(this byte[] @this)
        {
            hwRNG.GetBytes(@this);

            return @this;
        }

        /// <summary>
        /// Performs an element-by-element equality test between 
        /// <paramref name="this"/> and <paramref name="that"/>.
        /// </summary>
        /// <param name="this">Iself.</param>
        /// <param name="that">The array to compare to.</param>
        /// <returns> TRUE if all elements are equal.</returns>
        public static bool IsEqual(this byte[] @this, byte[] that)
        {
            if (ReferenceEquals(@this, that))
                return true;

            if (@this.Length != that.Length)
                return false;

            for (int i = 0; i < @this.Length; i++)
            {
                if (@this[i] != that[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Checks whether all elements in <paramref name="this"/> 
        /// are initialized to default value.
        /// </summary>
        /// <param name="this">Itself.</param>
        /// <returns>TRUE if all elements are set to default, FALSE otherwise.</returns>
        public static bool IsEmpty(this byte[] @this)
        {
            foreach (var item in @this)
            {
                if (item != default)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Converts <paramref name="this"/> to an array of <see cref="uint"/>.
        /// </summary>
        /// <returns>A new <see cref="uint"/> array.</returns>
        public static uint[] ToUInt32Array(this byte[] @this)
        {
            int uints = @this.Length / sizeof(uint);

            if (@this.Length % sizeof(uint) != 0)
                ++uints;

            var result = new uint[uints];

            Buffer.BlockCopy(@this, 0, result, 0, @this.Length);

            return result;
        }

        /// <summary>
        /// Converts <paramref name="this"/> to an array of <see cref="ulong"/>.
        /// </summary>
        /// <returns>A new <see cref="ulong"/> array.</returns>
        public static ulong[] ToUInt64Array(this byte[] @this)
        {
            int ulongs = @this.Length / sizeof(ulong);

            if (@this.Length % sizeof(ulong) != 0)
                ++ulongs;

            var result = new ulong[ulongs];

            Buffer.BlockCopy(@this, 0, result, 0, @this.Length);

            return result;
        }

        /// <summary>
        /// XORs each element of <paramref name="this"/> array with each element of 
        /// <paramref name="that"/> and overwrites the values in the current array.
        /// </summary>
        /// <param name="that">The array to XOR with.</param>
        /// <returns>A reference to itself.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static byte[] XOR(this byte[] @this, byte[] that)
        {
            if (@this.Length < that.Length)
                throw new ArgumentException(
                    $"Must be minimum {@this.Length} length.", nameof(that));

            for (int i = 0; i < @this.Length; i++)
                @this[i] = (byte)(@this[i] ^ that[i]);

            return @this;
        }
    }
}
