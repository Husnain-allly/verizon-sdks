
# Get Account Device Consent

*This model accepts additional fields of type interface{}.*

## Structure

`GetAccountDeviceConsent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceList` | `[]interface{}` | Optional | An array of device identifiers |
| `AccountName` | `*string` | Optional | The numeric name of the account, including leading zeros. |
| `AllDeviceConsent` | `*int` | Optional | If consent is set at the account level, this value will show the consent level. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "allDeviceConsent": 1,
  "deviceList": [
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

