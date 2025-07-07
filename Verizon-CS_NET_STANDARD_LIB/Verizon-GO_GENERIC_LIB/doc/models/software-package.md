
# Software Package

Software package information.

*This model accepts additional fields of type interface{}.*

## Structure

`SoftwarePackage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SoftwareName` | `string` | Required | Software name. |
| `LaunchDate` | `time.Time` | Required | Software launch date. |
| `ReleaseNote` | `*string` | Optional | Software release note reserved for future use. |
| `Model` | `string` | Required | Software applicable device model. |
| `Make` | `string` | Required | Software applicable device make. |
| `DistributionType` | `string` | Required | LWM2M, OMD-DM or HTTP. |
| `DevicePlatformId` | `string` | Required | The platform (Android, iOS, etc.) that the software can be applied to. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

