
# Get Trigger Response List

## Structure

`GetTriggerResponseList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Triggers` | [`List<GetTriggerResponse>`](../../doc/models/get-trigger-response.md) | Optional | **Constraints**: *Maximum Items*: `3` | List<GetTriggerResponse> getTriggers() | setTriggers(List<GetTriggerResponse> triggers) |

## Example (as JSON)

```json
{
  "triggers": [
    {
      "accountName": "accountName4",
      "comparator": "comparator2",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "groupName": "groupName0",
      "modifiedAt": "2016-03-13T12:52:32.123Z"
    },
    {
      "accountName": "accountName4",
      "comparator": "comparator2",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "groupName": "groupName0",
      "modifiedAt": "2016-03-13T12:52:32.123Z"
    }
  ]
}
```

