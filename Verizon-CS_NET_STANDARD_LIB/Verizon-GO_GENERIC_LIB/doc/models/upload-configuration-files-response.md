
# Upload Configuration Files Response

*This model accepts additional fields of type interface{}.*

## Structure

`UploadConfigurationFilesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FileName` | `*string` | Optional | The name of the file you are upgrading to. |
| `FileVersion` | `*string` | Optional | The version of the file you are upgrading to. |
| `LaunchDate` | `*time.Time` | Optional | Software launch date. |
| `ReleaseNote` | `*string` | Optional | Software release note. |
| `Model` | `*string` | Optional | Software applicable device model. |
| `Make` | `*string` | Optional | Software applicable device make. |
| `DistributionType` | `*string` | Optional | LWM2M, OMD-DM or HTTP. |
| `DevicePlatformId` | `*string` | Optional | The platform (Android, iOS, etc.) that the software can be applied to. |
| `LocalTargetPath` | `*string` | Optional | Local target path on the device. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

