
# Firmware Campaign

Firmware upgrade information.

*This model accepts additional fields of type unknown.*

## Structure

`FirmwareCampaign`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Required | Upgrade identifier. |
| `accountName` | `string` | Required | Account identifier. |
| `campaignName` | `string \| undefined` | Optional | Campaign name. |
| `firmwareName` | `string \| undefined` | Optional | Firmware name (for firmware upgrade only). |
| `firmwareFrom` | `string` | Required | Old firmware version (for firmware upgrade only). |
| `firmwareTo` | `string` | Required | New firmware version (for firmware upgrade only). |
| `protocol` | `string` | Required | Available values: LWM2M.<br><br>**Default**: `'LWM2M'` |
| `make` | `string` | Required | - |
| `model` | `string` | Required | - |
| `startDate` | `string` | Required | Campaign start date. |
| `endDate` | `string` | Required | Campaign end date. |
| `campaignTimeWindowList` | [`V3TimeWindow[] \| undefined`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |
| `status` | `string` | Required | Campaign status. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "id": "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
  "accountName": "0000123456-00001",
  "campaignName": "Smart FOTA - test 4",
  "firmwareName": "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
  "protocol": "LWM2M",
  "firmwareFrom": "SR1.2.0.0-10512",
  "firmwareTo": "SR1.2.0.0-10657",
  "make": "SEQUANS Communications",
  "model": "GM01Q",
  "status": "CampaignRequestPending",
  "startDate": "2021-09-29",
  "endDate": "2021-10-01",
  "campaignTimeWindowList": [
    {
      "startTime": 18,
      "endTime": 22,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

