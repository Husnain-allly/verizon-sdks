
# Get Account Device Consent

*This model accepts additional fields of type Object.*

## Structure

`GetAccountDeviceConsent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_list` | `Array<Object>` | Optional | An array of device identifiers |
| `account_name` | `String` | Optional | The numeric name of the account, including leading zeros. |
| `all_device_consent` | `Integer` | Optional | If consent is set at the account level, this value will show the consent level. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

