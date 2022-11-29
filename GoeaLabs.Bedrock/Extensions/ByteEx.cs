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
    public static class ByteEx
    {
        /// <summary>
        /// XORs two bytes.
        /// </summary>
        /// <param name="left">First byte.</param>
        /// <param name="right">Second byte.</param>
        /// <returns>The result of the XOR operation.</returns>
        public static byte XOR(this byte left, byte right) => (byte)(left ^ right);
    }
}
