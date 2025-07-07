
# Update Trigger Request

## Structure

`UpdateTriggerRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `Active` | `Boolean` | Optional | - | Boolean getActive() | setActive(Boolean active) |
| `AnomalyTriggerRequest` | [`AnomalyTriggerRequest`](../../doc/models/anomaly-trigger-request.md) | Optional | The details of the UsageAnomaly trigger. | AnomalyTriggerRequest getAnomalyTriggerRequest() | setAnomalyTriggerRequest(AnomalyTriggerRequest anomalyTriggerRequest) |
| `CycleType` | [`CycleType`](../../doc/models/cycle-type.md) | Optional | - | CycleType getCycleType() | setCycleType(CycleType cycleType) |
| `DataTriggerRequest` | [`DataTriggerRequest`](../../doc/models/data-trigger-request.md) | Optional | - | DataTriggerRequest getDataTriggerRequest() | setDataTriggerRequest(DataTriggerRequest dataTriggerRequest) |
| `GroupName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getGroupName() | setGroupName(String groupName) |
| `PromoAlertTriggerRequest` | [`PromoAlertTriggerRequest`](../../doc/models/promo-alert-trigger-request.md) | Optional | - | PromoAlertTriggerRequest getPromoAlertTriggerRequest() | setPromoAlertTriggerRequest(PromoAlertTriggerRequest promoAlertTriggerRequest) |
| `SessionTriggerRequest` | [`SessionTriggerRequest`](../../doc/models/session-trigger-request.md) | Optional | - | SessionTriggerRequest getSessionTriggerRequest() | setSessionTriggerRequest(SessionTriggerRequest sessionTriggerRequest) |
| `SmsTriggerRequest` | [`SmsTriggerRequest`](../../doc/models/sms-trigger-request.md) | Optional | - | SmsTriggerRequest getSmsTriggerRequest() | setSmsTriggerRequest(SmsTriggerRequest smsTriggerRequest) |
| `TriggerCategory` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getTriggerCategory() | setTriggerCategory(String triggerCategory) |
| `TriggerId` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getTriggerId() | setTriggerId(String triggerId) |
| `TriggerName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getTriggerName() | setTriggerName(String triggerName) |

## Example (as JSON)

```json
{
  "anomalyTriggerRequest": {
    "accountNames": "0000123456-00001",
    "includeAbnormal": true,
    "includeVeryAbnormal": true,
    "includeUnderExpectedUsage": true,
    "includeOverExpectedUsage": true
  },
  "accountName": "accountName0",
  "active": false,
  "cycleType": "cycleone",
  "dataTriggerRequest": {
    "comparator": "comparator2",
    "threshold": 100,
    "thresholdUnit": "thresholdUnit6"
  }
}
```

