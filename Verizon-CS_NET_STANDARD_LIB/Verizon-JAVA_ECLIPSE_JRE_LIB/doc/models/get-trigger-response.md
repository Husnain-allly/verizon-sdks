
# Get Trigger Response

## Structure

`GetTriggerResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `Comparator` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getComparator() | setComparator(String comparator) |
| `CreatedAt` | `LocalDateTime` | Optional | - | LocalDateTime getCreatedAt() | setCreatedAt(LocalDateTime createdAt) |
| `GroupName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getGroupName() | setGroupName(String groupName) |
| `ModifiedAt` | `LocalDateTime` | Optional | - | LocalDateTime getModifiedAt() | setModifiedAt(LocalDateTime modifiedAt) |
| `NotificationGroupName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getNotificationGroupName() | setNotificationGroupName(String notificationGroupName) |
| `OrganizationName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getOrganizationName() | setOrganizationName(String organizationName) |
| `SmsType` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getSmsType() | setSmsType(String smsType) |
| `Threshold` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getThreshold() | setThreshold(String threshold) |
| `ThresholdUnit` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getThresholdUnit() | setThresholdUnit(String thresholdUnit) |
| `TriggerCategory` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getTriggerCategory() | setTriggerCategory(String triggerCategory) |
| `TriggerCycle` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getTriggerCycle() | setTriggerCycle(String triggerCycle) |
| `TriggerId` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getTriggerId() | setTriggerId(String triggerId) |
| `TriggerName` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getTriggerName() | setTriggerName(String triggerName) |

## Example (as JSON)

```json
{
  "accountName": "accountName2",
  "comparator": "comparator4",
  "createdAt": "2016-03-13T12:52:32.123Z",
  "groupName": "groupName8",
  "modifiedAt": "2016-03-13T12:52:32.123Z"
}
```

