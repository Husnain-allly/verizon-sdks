
# Retrieves Available Files Response

*This model accepts additional fields of type Object.*

## Structure

`RetrievesAvailableFilesResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FileName` | `String` | Optional | ThingSpace-generated name of the file. You will use this name when listing or scheduling campaigns for the file. | String getFileName() | setFileName(String fileName) |
| `FileVersion` | `String` | Optional | Version of the file. | String getFileVersion() | setFileVersion(String fileVersion) |
| `ReleaseNote` | `String` | Optional | Software release note. | String getReleaseNote() | setReleaseNote(String releaseNote) |
| `Make` | `String` | Optional | The software-applicable device make. | String getMake() | setMake(String make) |
| `Model` | `String` | Optional | The software-applicable device model. | String getModel() | setModel(String model) |
| `LocalTargetPath` | `String` | Optional | Local target path on the device. | String getLocalTargetPath() | setLocalTargetPath(String localTargetPath) |
| `DistributionType` | `String` | Optional | Valid values | String getDistributionType() | setDistributionType(String distributionType) |
| `DevicePlatformId` | `String` | Optional | The platform (Android, iOS, etc.,) that the software can be applied to. | String getDevicePlatformId() | setDevicePlatformId(String devicePlatformId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "fileName": "configfile-Verizon_VZW1_hello-world.txt",
  "fileVersion": "1.0",
  "releaseNote": "Hello world initial file",
  "make": "Verizon",
  "model": "VZW1",
  "localTargetPath": "/VZWFOTA/hello-world.txt",
  "distributionType": "HTTP",
  "devicePlatformId": "IoT",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

