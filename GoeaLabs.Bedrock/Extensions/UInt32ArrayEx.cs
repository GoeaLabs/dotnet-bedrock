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

namespace GoeaLabs.Bedrock.Extensions
{
    public static class UInt32ArrayEx
    {
        /// <summary>
        /// Fills the array with true random <see cref="uint"/>s.
        /// </summary>
        /// <returns>A reference to itself.</returns>
        public static uint[] FillRandom(this uint[] @this)
        {
            var buff = new byte[@this.Length * sizeof(uint)];

            buff.FillRandom();

            Buffer.BlockCopy(buff, 0, @this, 0, buff.Length);

            return @this;
        }

        /// <summary>
        /// Checks if all elements in the array are set to default value.
        /// </summary>
        /// <returns>
        /// TRUE if all elements are set to default, otherwise FALSE.
        /// </returns>
        public static bool IsEmpty(this uint[] @this)
        {
            foreach (var item in @this)
            {
                if (item != default)
                    return false;
            }

            return true;
        }
    }
}
