
# Firmware

Firmware information.

*This model accepts additional fields of type object.*

## Structure

`Firmware`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirmwareName` | `string` | Optional | The name of the firmware image, provided by the device manufacturer. |
| `ParticipantName` | `string` | Optional | Internal reference; can be ignored. |
| `LaunchDate` | `DateTime?` | Optional | The release date of the firmware image. |
| `ReleaseNote` | `string` | Optional | Additional information about the release. |
| `Model` | `string` | Optional | The device model that the firmware applies to. |
| `Make` | `string` | Optional | The device make that the firmware applies to. |
| `FromVersion` | `string` | Optional | The firmware version that must currently be on the device to upgrade. |
| `ToVersion` | `string` | Optional | The firmware version that will be on the device after an upgrade. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "firmwareName": "FOTA_Verizon_Model-A_01To02_HF",
  "participantName": "0402196254-00001",
  "launchDate": "2018-04-01T16:03:00.000Z",
  "releaseNote": "",
  "model": "Model-A",
  "make": "Verizon",
  "fromVersion": "VerizonFirmwareVersion-01",
  "toVersion": "VerizonFirmwareVersion-02",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

