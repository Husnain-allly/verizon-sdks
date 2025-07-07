
# V3 Campaign Meta Info

Campaign and campaign details.

*This model accepts additional fields of type Any.*

## Structure

`V3CampaignMetaInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Required | Account identifier. |
| `id` | `str` | Required | Campaign identifier. |
| `campaign_name` | `str` | Optional | Campaign name. |
| `firmware_name` | `str` | Optional | Firmware name. |
| `firmware_from` | `str` | Optional | Old firmware version. |
| `firmware_to` | `str` | Optional | New software version. |
| `protocol` | [`CampaignMetaInfoProtocol`](../../doc/models/campaign-meta-info-protocol.md) | Optional | Firmware protocol. Valid values include: LWM2M, OMD-DM.<br><br>**Default**: `'LWM2M'` |
| `make` | `str` | Required | Device make. |
| `model` | `str` | Required | Device model. |
| `start_date` | `date` | Required | Campaign start date. |
| `end_date` | `date` | Required | Campaign end date. |
| `campaign_time_window_list` | [`List[V3TimeWindow]`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |
| `status` | `str` | Required | Firmware upgrade status. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "campaignName": "FOTA_Verizon_Upgrade",
  "firmwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "firmwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "firmwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "make": "Verizon",
  "model": "Model-A",
  "status": "CampaignEnded",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "campaignTimeWindowList": [
    {
      "startTime": 20,
      "endTime": 21
    }
  ],
  "protocol": "LWM2M",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

