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
    public static class UInt64Ex
    {
        /// <summary>
        /// Splits the <see cref="ulong"/> in two <see cref="uint"/>s.
        /// </summary>
        /// <param name="msp">The most significant part.</param>
        /// <param name="lsp">The least significant part.</param>
        public static void Split(this ulong @this, out uint msp, out uint lsp)
        {
            msp = (uint)(@this >> 32);
            lsp = (uint)@this;
        }
    }
}
