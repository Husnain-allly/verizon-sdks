
# Firmware

Firmware information.

*This model accepts additional fields of type Object.*

## Structure

`Firmware`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FirmwareName` | `String` | Optional | The name of the firmware image, provided by the device manufacturer. | String getFirmwareName() | setFirmwareName(String firmwareName) |
| `ParticipantName` | `String` | Optional | Internal reference; can be ignored. | String getParticipantName() | setParticipantName(String participantName) |
| `LaunchDate` | `LocalDateTime` | Optional | The release date of the firmware image. | LocalDateTime getLaunchDate() | setLaunchDate(LocalDateTime launchDate) |
| `ReleaseNote` | `String` | Optional | Additional information about the release. | String getReleaseNote() | setReleaseNote(String releaseNote) |
| `Model` | `String` | Optional | The device model that the firmware applies to. | String getModel() | setModel(String model) |
| `Make` | `String` | Optional | The device make that the firmware applies to. | String getMake() | setMake(String make) |
| `FromVersion` | `String` | Optional | The firmware version that must currently be on the device to upgrade. | String getFromVersion() | setFromVersion(String fromVersion) |
| `ToVersion` | `String` | Optional | The firmware version that will be on the device after an upgrade. | String getToVersion() | setToVersion(String toVersion) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

