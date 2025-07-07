
# Upload Configuration Files Response

*This model accepts additional fields of type Object.*

## Structure

`UploadConfigurationFilesResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FileName` | `String` | Optional | The name of the file you are upgrading to. | String getFileName() | setFileName(String fileName) |
| `FileVersion` | `String` | Optional | The version of the file you are upgrading to. | String getFileVersion() | setFileVersion(String fileVersion) |
| `LaunchDate` | `LocalDate` | Optional | Software launch date. | LocalDate getLaunchDate() | setLaunchDate(LocalDate launchDate) |
| `ReleaseNote` | `String` | Optional | Software release note. | String getReleaseNote() | setReleaseNote(String releaseNote) |
| `Model` | `String` | Optional | Software applicable device model. | String getModel() | setModel(String model) |
| `Make` | `String` | Optional | Software applicable device make. | String getMake() | setMake(String make) |
| `DistributionType` | `String` | Optional | LWM2M, OMD-DM or HTTP. | String getDistributionType() | setDistributionType(String distributionType) |
| `DevicePlatformId` | `String` | Optional | The platform (Android, iOS, etc.) that the software can be applied to. | String getDevicePlatformId() | setDevicePlatformId(String devicePlatformId) |
| `LocalTargetPath` | `String` | Optional | Local target path on the device. | String getLocalTargetPath() | setLocalTargetPath(String localTargetPath) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "fileName": "hello-world.txt",
  "fileVersion": "1.0",
  "launchDate": "2020-08-31",
  "releaseNote": "note",
  "model": "Model-A",
  "make": "Verizon",
  "distributionType": "HTTP",
  "devicePlatformId": "IoT",
  "localTargetPath": "IoT",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

