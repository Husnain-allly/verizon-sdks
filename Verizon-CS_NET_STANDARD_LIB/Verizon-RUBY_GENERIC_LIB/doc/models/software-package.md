
# Software Package

Software package information.

*This model accepts additional fields of type Object.*

## Structure

`SoftwarePackage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `software_name` | `String` | Required | Software name. |
| `launch_date` | `Date` | Required | Software launch date. |
| `release_note` | `String` | Optional | Software release note reserved for future use. |
| `model` | `String` | Required | Software applicable device model. |
| `make` | `String` | Required | Software applicable device make. |
| `distribution_type` | `String` | Required | LWM2M, OMD-DM or HTTP. |
| `device_platform_id` | `String` | Required | The platform (Android, iOS, etc.) that the software can be applied to. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "launchDate": "2020-08-31",
  "releaseNote": "",
  "model": "Model-A",
  "make": "Verizon",
  "distributionType": "HTTP",
  "devicePlatformId": "IoT",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

