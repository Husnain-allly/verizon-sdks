
# Account Consent Update

*This model accepts additional fields of type Object.*

## Structure

`AccountConsentUpdate`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The numeric name of the account, including leading zeros. | String getAccountName() | setAccountName(String accountName) |
| `AllDeviceConsent` | `Integer` | Optional | The consent setting to use for all the devices in the account. | Integer getAllDeviceConsent() | setAllDeviceConsent(Integer allDeviceConsent) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

