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
    public class UInt32ArrayExTests
    {
        [TestMethod]
        public void FilRandom_behaves_correctly()
        {
            uint[] self = new uint[100];

            Assert.IsFalse(self.FillRandom().IsEmpty());
        }

        [TestMethod]
        [DataRow(new uint[2] { default, default })]
        public void IsEmpty_returns_true_when_array_is_empty(uint[] self) => Assert.IsTrue(self.IsEmpty());

        [TestMethod]
        [DataRow(new uint[] { 0, 1 })]
        public void IsEmpty_returns_false_when_array_is_not_empty(uint[] self) => Assert.IsFalse(self.IsEmpty());
    }
}
