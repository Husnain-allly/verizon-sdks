
# Status Response

## Structure

`StatusResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RequestId` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^[a-z-0-9]{3,64}$` | String getRequestId() | setRequestId(String requestId) |
| `Status` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getStatus() | setStatus(String status) |
| `Subrequests` | [`List<Subrequest>`](../../doc/models/subrequest.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<Subrequest> getSubrequests() | setSubrequests(List<Subrequest> subrequests) |

## Example (as JSON)

```json
{
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8",
  "status": "Success",
  "subrequests": [
    {
      "ids": {
        "kind": "kind2",
        "id": "id4"
      },
      "status": "status2"
    }
  ]
}
```

