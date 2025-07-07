
# Device Group Filter

*This model accepts additional fields of type Any.*

## Structure

`DeviceGroupFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_group_name` | `str` | Optional | - |
| `individual_or_combined` | `str` | Optional | - |
| `account_name` | `str` | Optional | The numeric name of the account and must include leading zeroes |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

