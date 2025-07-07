
# Message Base

*This model accepts additional fields of type Object.*

## Structure

`MessageBase`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `IsPrivate` | `boolean` | Required | Defines whether the message is private or public.<br>Private messages are published under the Vendor ID defined in the configuration and only visible to devices of selected vendors.<br>Public messages are published under the Public vendor and are visible to all the users. | boolean getIsPrivate() | setIsPrivate(boolean isPrivate) |
| `RoadUserType` | [`List<RoadUserTypes>`](../../doc/models/road-user-types.md) | Required | Type of the Road User.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` | List<RoadUserTypes> getRoadUserType() | setRoadUserType(List<RoadUserTypes> roadUserType) |
| `TriggerConditions` | [`List<TriggerCondition>`](../../doc/models/trigger-condition.md) | Optional | Trigger conditions that define on which road user action the message will be sent. If multiple Trigger Conditions are defined any of them will trigger the message.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `3` | List<TriggerCondition> getTriggerConditions() | setTriggerConditions(List<TriggerCondition> triggerConditions) |
| `Limits` | `List<Object>` | Optional | List of limitations. These limitations can be used for making the trigger condition more precise by defining speed and motion direction requirements to be met before the messages are sent out.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` | List<Object> getLimits() | setLimits(List<Object> limits) |
| `DistributionType` | [`List<DistributionTypes>`](../../doc/models/distribution-types.md) | Optional | Type of the distribution.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` | List<DistributionTypes> getDistributionType() | setDistributionType(List<DistributionTypes> distributionType) |
| `DistributionSchedule` | [`DistributionSchedule`](../../doc/models/distribution-schedule.md) | Optional | The distribution schedule parameters for broadcast messages. | DistributionSchedule getDistributionSchedule() | setDistributionSchedule(DistributionSchedule distributionSchedule) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "isPrivate": false,
  "roadUserType": [
    "VulnerableRoadUser"
  ],
  "triggerConditions": [
    "crossing"
  ],
  "limits": [
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "distributionType": [
    "Broadcast",
    "Targeted",
    "Broadcast"
  ],
  "distributionSchedule": {
    "repeatPeriod": 90,
    "duration": 88,
    "startTime": "2016-03-13T12:52:32.123Z"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

