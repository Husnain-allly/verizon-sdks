
# V2 Add or Remove Device Result

Add or remove devices from the existing software upgrade information.

*This model accepts additional fields of type Object.*

## Structure

`V2AddOrRemoveDeviceResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account identifier. | String getAccountName() | setAccountName(String accountName) |
| `CampaignId` | `String` | Required | Campaign identifier. | String getCampaignId() | setCampaignId(String campaignId) |
| `RequestId` | `String` | Required | Request identifier. | String getRequestId() | setRequestId(String requestId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0402196254-00001",
  "campaignId": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "requestId": "requestId6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

