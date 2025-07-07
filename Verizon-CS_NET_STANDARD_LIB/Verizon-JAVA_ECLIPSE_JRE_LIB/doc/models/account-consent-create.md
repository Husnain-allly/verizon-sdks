
# Account Consent Create

*This model accepts additional fields of type Object.*

## Structure

`AccountConsentCreate`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceList` | `List<Object>` | Optional | An array of device identifiers | List<Object> getDeviceList() | setDeviceList(List<Object> deviceList) |
| `AccountName` | `String` | Optional | The numeric name of the account, including leading zeros. | String getAccountName() | setAccountName(String accountName) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "deviceList": [
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    },
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

