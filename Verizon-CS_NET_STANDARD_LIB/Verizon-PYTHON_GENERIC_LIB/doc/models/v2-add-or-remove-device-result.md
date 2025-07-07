
# V2 Add or Remove Device Result

Add or remove devices from the existing software upgrade information.

*This model accepts additional fields of type Any.*

## Structure

`V2AddOrRemoveDeviceResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Required | Account identifier. |
| `campaign_id` | `str` | Required | Campaign identifier. |
| `request_id` | `str` | Required | Request identifier. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

