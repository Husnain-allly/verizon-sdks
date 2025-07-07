
# Compute Resources Type

Compute resources of a service profile.

## Structure

`ComputeResourcesType`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `gpu` | [`?Gpu`](../../doc/models/gpu.md) | Optional | GPU resources of a service profile. | getGpu(): ?Gpu | setGpu(?Gpu gpu): void |
| `minRamgb` | `?int` | Optional | Minimum RAM required in Gigabytes.<br><br>**Constraints**: `>= 1`, `<= 100` | getMinRamgb(): ?int | setMinRamgb(?int minRamgb): void |
| `minStorageGb` | `?int` | Optional | Minimum storage requirement in Gigabytes.<br><br>**Constraints**: `>= 1`, `<= 100` | getMinStorageGb(): ?int | setMinStorageGb(?int minStorageGb): void |

## Example (as JSON)

```json
{
  "minRAMGB": 1,
  "minStorageGB": 1,
  "GPU": {
    "minCoreClockMHz": 76,
    "minMemoryClockMHz": 20,
    "minBandwidthGBs": 96,
    "minTFLOPS": 100
  }
}
```

