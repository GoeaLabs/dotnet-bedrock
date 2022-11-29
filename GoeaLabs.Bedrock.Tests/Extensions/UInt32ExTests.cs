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
    public class UInt32ExTests
    {
        [TestMethod]
        [DataRow(3735936685, 3235823838, 16045725885237477598)]
        public void Join_behaves_correctly(uint msp, uint lsp, ulong n64) => Assert.IsTrue(msp.Join(lsp) == n64);
    }
}
