
# Device Group Filter

*This model accepts additional fields of type unknown.*

## Structure

`DeviceGroupFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceGroupName` | `string \| undefined` | Optional | - |
| `individualOrCombined` | `string \| undefined` | Optional | - |
| `accountName` | `string \| undefined` | Optional | The numeric name of the account and must include leading zeroes |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

