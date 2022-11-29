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

using GoeaLabs.Bedrock.Extensions;

namespace GoeaLabs.Bedrock.Tests.Extensions
{
    [TestClass]
    public class UInt64ExTests
    {
        [TestMethod]
        [DataRow(16045725885237477598, 3735936685, 3235823838)]
        public void Split_behaves_correctly(ulong n64, uint msp, uint lsp)
        {
            n64.Split(out uint h32, out uint l32);

            Assert.IsTrue(h32 == msp && l32 == lsp);
        }

    }
}
