
# V1 List of Licenses to Remove Request

List of devices to removes.

*This model accepts additional fields of type interface{}.*

## Structure

`V1ListOfLicensesToRemoveRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `*string` | Optional | Set to 'append' to append the devices in the current request to the existing list. If there is no existing list then it will be created with only these devices. Leave this parameter out when you want to replace the existing list with the devices in the current request. |
| `DeviceList` | `[]string` | Required | The IMEIs of the devices. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "type": "append",
  "deviceList": [
    "990003425730535",
    "990000473475989"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

