
# Device Group Filter

*This model accepts additional fields of type object.*

## Structure

`DeviceGroupFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceGroupName` | `string` | Optional | - |
| `IndividualOrCombined` | `string` | Optional | - |
| `AccountName` | `string` | Optional | The numeric name of the account and must include leading zeroes |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

