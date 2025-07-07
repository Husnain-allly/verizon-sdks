
# Software Package

Software package information.

*This model accepts additional fields of type Object.*

## Structure

`SoftwarePackage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `SoftwareName` | `String` | Required | Software name. | String getSoftwareName() | setSoftwareName(String softwareName) |
| `LaunchDate` | `LocalDate` | Required | Software launch date. | LocalDate getLaunchDate() | setLaunchDate(LocalDate launchDate) |
| `ReleaseNote` | `String` | Optional | Software release note reserved for future use. | String getReleaseNote() | setReleaseNote(String releaseNote) |
| `Model` | `String` | Required | Software applicable device model. | String getModel() | setModel(String model) |
| `Make` | `String` | Required | Software applicable device make. | String getMake() | setMake(String make) |
| `DistributionType` | `String` | Required | LWM2M, OMD-DM or HTTP. | String getDistributionType() | setDistributionType(String distributionType) |
| `DevicePlatformId` | `String` | Required | The platform (Android, iOS, etc.) that the software can be applied to. | String getDevicePlatformId() | setDevicePlatformId(String devicePlatformId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

