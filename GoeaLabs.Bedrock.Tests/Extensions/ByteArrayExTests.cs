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
    public class ByteArrayExTests
    {
        [TestMethod]
        [DataRow(
            new byte[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 
            new byte[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        public void IsEqual_returns_true_when_arrays_are_equal(byte[] self, byte[] that) => Assert.IsTrue(self.IsEqual(that));

        [TestMethod]
        [DataRow(new byte[] { 10, 11 }, new byte[] { 11, 12 })]
        [DataRow(new byte[] { 0 }, new byte[] { 0, 1 })]
        public void IsEqual_returns_false_when_arrays_are_not_equal(byte[] self, byte[] that) => Assert.IsFalse(self.IsEqual(that));

        [TestMethod]
        [DataRow(new byte[2] { default, default })]
        public void IsEmpty_returns_true_when_array_is_empty(byte[] self) => Assert.IsTrue(self.IsEmpty());

        [TestMethod]
        [DataRow(new byte[] { 0, 1 })]
        public void IsEmpty_returns_false_when_array_is_not_empty(byte[] self) => Assert.IsFalse(self.IsEmpty());

        [TestMethod]
        [DataRow(new byte[] { 0, 1 }, new byte[] { 0, 1, 2 })]
        [ExpectedException(typeof(ArgumentException))]
        public void XOR_throws_ArgumentException_if_self_length_not_greater_than_that_length(byte[] self, byte[] that) => self.XOR(that);


        [TestMethod]
        [DataRow(new byte[] { 1, 2, 3, 4 }, new byte[] { 5, 6, 7, 8 }, new byte[] { 4, 4, 4, 12 })]
        public void XOR_correctly_xors_the_arrays(byte[] self, byte[] that, byte[] okay) => Assert.IsTrue(self.XOR(that).IsEqual(okay));

        [TestMethod]
        [DataRow(new byte[] { 1, 2, 3, 4 }, new byte[] { 5, 6, 7, 8 }, new byte[] { 4, 4, 4, 12 })]
        public void XOR_correctly_overwrites_self_when_same_is_true(byte[] self, byte[] that, byte[] okay) => Assert.IsTrue(self.XOR(that).IsEqual(okay));

        [TestMethod]
        [DataRow(new byte[] { 0, 1, 2 }, 0, 131328U)]
        [DataRow(new byte[] { 0, 1, 2, 3 }, 0, 50462976U)]
        [DataRow(new byte[] { 0, 1, 2, 3, 4, 5 }, 1, 1284U)]
        public void ToUInt32Array_beaves_correctly(byte[] input, int index, uint valid) => Assert.IsTrue(input.ToUInt32Array()[index] == valid);

        [TestMethod]
        [DataRow(new byte[] { 0, 1, 2, 3, 4, 5, 6 }, 0, 1694364648734976UL)]
        [DataRow(new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 0, 506097522914230528UL)]
        [DataRow(new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 1, 185207048UL)]
        public void ToUInt64Array_behaves_correctly(byte[] input, int index, ulong valid) => Assert.IsTrue(input.ToUInt64Array()[index] == valid);

        [TestMethod]
        [DataRow(1000)]
        public void FillRandom_behaves_correctly(int count) => Assert.IsFalse(new byte[count].FillRandom().IsEmpty());
    }
}
