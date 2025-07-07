
# Fall Back

*This model accepts additional fields of type Object.*

## Structure

`FallBack`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `devices` | [`Array<DeviceIdarray>`](../../doc/models/device-idarray.md) | Optional | An array containing the `deviceId` array.<br><br>**Constraints**: *Maximum Items*: `100` |
| `account_name` | `String` | Optional | The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "devices": [
    [
      {
        "kind": "kind2",
        "id": "id4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "kind": "kind2",
        "id": "id4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ],
    [
      {
        "kind": "kind2",
        "id": "id4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      {
        "kind": "kind2",
        "id": "id4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ]
  ],
  "accountName": "accountName4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

