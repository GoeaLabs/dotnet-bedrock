### GoeaLabs.Bedrock

![GitHub](https://img.shields.io/github/license/GoeaLabs/dotnet-bedrock?style=for-the-badge)
![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/GoeaLabs/dotnet-bedrock?include_prereleases&style=for-the-badge)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/GoeaLabs.Bedrock?style=for-the-badge)

A collection of general purpose helper methods used by other **GoeaLabs** libraries.


#### API

| Method                                                   | Namespace                         |
|----------------------------------------------------------|-----------------------------------|
| ```FillRandom(this byte[] @this) : byte[]```             | ```GoeaLabs.Bedrock.Extensions``` |
| ```FillRandom(this uint[] @this) : uint[]```             | ```GoeaLabs.Bedrock.Extensions``` |
| ```IsEqual(this byte[] @this, byte[] that) : bool```     | ```GoeaLabs.Bedrock.Extensions``` |
| ```IsEmpty(this byte[] @this) : bool```                  | ```GoeaLabs.Bedrock.Extensions``` |
| ```IsEmpty(this uint[] @this) : bool```                  | ```GoeaLabs.Bedrock.Extensions``` |
| ```Join(this uint @this, uint input) : ulong```          | ```GoeaLabs.Bedrock.Extensions``` |
| ```Split(this ulong @this, out uint msp, out uint lsp)```| ```GoeaLabs.Bedrock.Extensions``` |
| ```ToUInt32Array(this byte[] @this) : uint[]```          | ```GoeaLabs.Bedrock.Extensions``` |
| ```ToUInt64Array(this byte[] @this) : ulong[]```         | ```GoeaLabs.Bedrock.Extensions``` |
| ```XOR(this byte[] @this, byte[] that) : byte[]```       | ```GoeaLabs.Bedrock.Extensions``` |
| ```XOR(this byte @this, byte that) : byte```             | ```GoeaLabs.Bedrock.Extensions``` |