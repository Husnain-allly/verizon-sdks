
# Software Package

Software package information.

*This model accepts additional fields of type unknown.*

## Structure

`SoftwarePackage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `softwareName` | `string` | Required | Software name. |
| `launchDate` | `string` | Required | Software launch date. |
| `releaseNote` | `string \| undefined` | Optional | Software release note reserved for future use. |
| `model` | `string` | Required | Software applicable device model. |
| `make` | `string` | Required | Software applicable device make. |
| `distributionType` | `string` | Required | LWM2M, OMD-DM or HTTP. |
| `devicePlatformId` | `string` | Required | The platform (Android, iOS, etc.) that the software can be applied to. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

