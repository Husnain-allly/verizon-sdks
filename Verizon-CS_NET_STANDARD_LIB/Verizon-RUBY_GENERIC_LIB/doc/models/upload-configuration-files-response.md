
# Upload Configuration Files Response

*This model accepts additional fields of type Object.*

## Structure

`UploadConfigurationFilesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file_name` | `String` | Optional | The name of the file you are upgrading to. |
| `file_version` | `String` | Optional | The version of the file you are upgrading to. |
| `launch_date` | `Date` | Optional | Software launch date. |
| `release_note` | `String` | Optional | Software release note. |
| `model` | `String` | Optional | Software applicable device model. |
| `make` | `String` | Optional | Software applicable device make. |
| `distribution_type` | `String` | Optional | LWM2M, OMD-DM or HTTP. |
| `device_platform_id` | `String` | Optional | The platform (Android, iOS, etc.) that the software can be applied to. |
| `local_target_path` | `String` | Optional | Local target path on the device. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

