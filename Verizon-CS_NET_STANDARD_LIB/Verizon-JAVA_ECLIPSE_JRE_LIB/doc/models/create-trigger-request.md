
# Create Trigger Request

## Structure

`CreateTriggerRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `AnomalyTriggerRequest` | [`AnomalyTriggerRequest`](../../doc/models/anomaly-trigger-request.md) | Optional | The details of the UsageAnomaly trigger. | AnomalyTriggerRequest getAnomalyTriggerRequest() | setAnomalyTriggerRequest(AnomalyTriggerRequest anomalyTriggerRequest) |
| `DataTriggerRequest` | [`DataTriggerRequest`](../../doc/models/data-trigger-request.md) | Optional | - | DataTriggerRequest getDataTriggerRequest() | setDataTriggerRequest(DataTriggerRequest dataTriggerRequest) |
| `GroupName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getGroupName() | setGroupName(String groupName) |
| `Name` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getName() | setName(String name) |
| `SessionTriggerRequest` | [`SessionTriggerRequest`](../../doc/models/session-trigger-request.md) | Optional | - | SessionTriggerRequest getSessionTriggerRequest() | setSessionTriggerRequest(SessionTriggerRequest sessionTriggerRequest) |
| `SmsTriggerRequest` | [`SmsTriggerRequest`](../../doc/models/sms-trigger-request.md) | Optional | - | SmsTriggerRequest getSmsTriggerRequest() | setSmsTriggerRequest(SmsTriggerRequest smsTriggerRequest) |
| `TriggerCategory` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getTriggerCategory() | setTriggerCategory(String triggerCategory) |
| `TriggerCycle` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getTriggerCycle() | setTriggerCycle(String triggerCycle) |

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
  "accountName": "accountName6",
  "dataTriggerRequest": {
    "comparator": "comparator2",
    "threshold": 100,
    "thresholdUnit": "thresholdUnit6"
  },
  "groupName": "groupName2",
  "name": "name2"
}
```

