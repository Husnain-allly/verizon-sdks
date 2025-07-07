
# Software Package

Software package information.

*This model accepts additional fields of type Any.*

## Structure

`SoftwarePackage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `software_name` | `str` | Required | Software name. |
| `launch_date` | `date` | Required | Software launch date. |
| `release_note` | `str` | Optional | Software release note reserved for future use. |
| `model` | `str` | Required | Software applicable device model. |
| `make` | `str` | Required | Software applicable device make. |
| `distribution_type` | `str` | Required | LWM2M, OMD-DM or HTTP. |
| `device_platform_id` | `str` | Required | The platform (Android, iOS, etc.) that the software can be applied to. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

