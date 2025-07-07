
# Etx Client Type

The type of the client that is to be registered. This is one of the major traffic participant groups considered in V2X communication. The system uses this value to define which topics the client will be able to publish and subscribe to.

Values:

- **Vehicle** - Vehicle with an enclosure around the passengers. (Subtypes: PassengerCar, Truck, Bus, EmergencyVehicle, SchoolBus, MaintenanceVehicle)
- **VulnerableRoadUser** - Traffic participants without a protecting enclosure. (Subtypes: Motorcycle, Bicycle, Pedestrian, Scooter)
- **TrafficLightController** - A Traffic light controller system. (Subtypes: NA)
- **InfrastructureSensor** - Sensors that are deployed in the infrastructure. (Subtypes: RoadSideUnit, Camera, Lidar, Radar, InductiveLoop, MagneticSensor)
- **OnboardSensor** - Sensors that are onboard on a vehicle(Subtypes: Camera, Lidar, Radar)
- **Software** - A software system or application. (Subtypes: Platform, Application, NA)

## Enumeration

`EtxClientType`

## Fields

| Name |
|  --- |
| `VEHICLE` |
| `VULNERABLEROADUSER` |
| `TRAFFICLIGHTCONTROLLER` |
| `INFRASTRUCTURESENSOR` |
| `ONBOARDSENSOR` |
| `SOFTWARE` |

