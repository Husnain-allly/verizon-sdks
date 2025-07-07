
# Gpu

GPU resources of a service profile.

## Structure

`Gpu`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `MinCoreClockMHz` | `Integer` | Optional | Minimum Core Clock value in megahertz.<br><br>**Constraints**: `>= 1`, `<= 10000` | Integer getMinCoreClockMHz() | setMinCoreClockMHz(Integer minCoreClockMHz) |
| `MinMemoryClockMHz` | `Integer` | Optional | Minimum Memory Clock value in megahertz.<br><br>**Constraints**: `>= 1`, `<= 100000` | Integer getMinMemoryClockMHz() | setMinMemoryClockMHz(Integer minMemoryClockMHz) |
| `MinBandwidthGBs` | `Integer` | Optional | Minimum GPU bandwidth in GB/s.<br><br>**Constraints**: `>= 1`, `<= 1000` | Integer getMinBandwidthGBs() | setMinBandwidthGBs(Integer minBandwidthGBs) |
| `MinTflops` | `Integer` | Optional | Minimum Floating Point Operations Per Second in Teraflops.<br><br>**Constraints**: `>= 1`, `<= 100` | Integer getMinTflops() | setMinTflops(Integer minTflops) |

## Example (as JSON)

```json
{
  "minCoreClockMHz": 1,
  "minMemoryClockMHz": 35740,
  "minBandwidthGBs": 588,
  "minTFLOPS": 33
}
```

