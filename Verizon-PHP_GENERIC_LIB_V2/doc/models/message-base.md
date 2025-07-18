
# Message Base

*This model accepts additional fields of type array.*

## Structure

`MessageBase`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `isPrivate` | `bool` | Required | Defines whether the message is private or public.<br>Private messages are published under the Vendor ID defined in the configuration and only visible to devices of selected vendors.<br>Public messages are published under the Public vendor and are visible to all the users. | getIsPrivate(): bool | setIsPrivate(bool isPrivate): void |
| `roadUserType` | [`string(RoadUserTypes)[]`](../../doc/models/road-user-types.md) | Required | Type of the Road User.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` | getRoadUserType(): array | setRoadUserType(array roadUserType): void |
| `triggerConditions` | [`?(string(TriggerCondition)[])`](../../doc/models/trigger-condition.md) | Optional | Trigger conditions that define on which road user action the message will be sent. If multiple Trigger Conditions are defined any of them will trigger the message.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `3` | getTriggerConditions(): ?array | setTriggerConditions(?array triggerConditions): void |
| `limits` | `?(array[])` | Optional | List of limitations. These limitations can be used for making the trigger condition more precise by defining speed and motion direction requirements to be met before the messages are sent out.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` | getLimits(): ?array | setLimits(?array limits): void |
| `distributionType` | [`?(string(DistributionTypes)[])`](../../doc/models/distribution-types.md) | Optional | Type of the distribution.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `2` | getDistributionType(): ?array | setDistributionType(?array distributionType): void |
| `distributionSchedule` | [`?DistributionSchedule`](../../doc/models/distribution-schedule.md) | Optional | The distribution schedule parameters for broadcast messages. | getDistributionSchedule(): ?DistributionSchedule | setDistributionSchedule(?DistributionSchedule distributionSchedule): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

