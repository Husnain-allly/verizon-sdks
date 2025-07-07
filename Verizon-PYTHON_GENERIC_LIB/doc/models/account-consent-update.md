
# Account Consent Update

*This model accepts additional fields of type Any.*

## Structure

`AccountConsentUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Optional | The numeric name of the account, including leading zeros. |
| `all_device_consent` | `int` | Optional | The consent setting to use for all the devices in the account. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "allDeviceConsent": 0,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

