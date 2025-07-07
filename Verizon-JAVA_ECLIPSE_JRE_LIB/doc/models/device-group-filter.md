
# Device Group Filter

*This model accepts additional fields of type Object.*

## Structure

`DeviceGroupFilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceGroupName` | `String` | Optional | - | String getDeviceGroupName() | setDeviceGroupName(String deviceGroupName) |
| `IndividualOrCombined` | `String` | Optional | - | String getIndividualOrCombined() | setIndividualOrCombined(String individualOrCombined) |
| `AccountName` | `String` | Optional | The numeric name of the account and must include leading zeroes | String getAccountName() | setAccountName(String accountName) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceGroupName": "User defined group name",
  "IndividualOrCombined": "Combined",
  "accountName": "0000123456-00001",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

