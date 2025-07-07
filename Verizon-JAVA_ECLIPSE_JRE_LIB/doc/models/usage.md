
# Usage

The daily network data usage of a single device during a specified time period.

*This model accepts additional fields of type Object.*

## Structure

`Usage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `BytesUsed` | `Long` | Optional | The number of bytes that the device sent or received on the report date. | Long getBytesUsed() | setBytesUsed(Long bytesUsed) |
| `ExtendedAttributes` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | The number of mobile-originated and mobile-terminated SMS messages on the report date. | List<CustomFields> getExtendedAttributes() | setExtendedAttributes(List<CustomFields> extendedAttributes) |
| `ServicePlan` | `String` | Optional | The list of service plans associated with the device/account. | String getServicePlan() | setServicePlan(String servicePlan) |
| `SmsUsed` | `Integer` | Optional | The number of SMS messages that were sent or received on the report date. | Integer getSmsUsed() | setSmsUsed(Integer smsUsed) |
| `Source` | `String` | Optional | The source of the information for the reported usage. | String getSource() | setSource(String source) |
| `Timestamp` | `String` | Optional | The date of the recorded usage. | String getTimestamp() | setTimestamp(String timestamp) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "bytesUsed": 4096,
  "extendedAttributes": [
    {
      "key": "MoSms",
      "value": "0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "smsUsed": 0,
  "source": "Raw Usage",
  "timestamp": "2020-12-01T00:00:00Z",
  "servicePlan": "servicePlan6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

