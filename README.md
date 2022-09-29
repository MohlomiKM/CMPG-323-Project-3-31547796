# CMPG-323-Project-3-31547796

# Connected Office Web App

## Uses
Users Manage a record of all their devices specifying the category and zones of the devices.
1. Users Create Categories (each category with its description) for their devices.
2. Users Create Zones (each zone with its description) for thier devices.
3. Users thereafter Create Devices with the new or previously created category & zone available on the dropdown list relating to the device, lastly users add the status of the device.

Users can therefore edit, view details & delete the created categories, zones & devices.

## Implementation
Tier 2 Repository Pattern is implemented for Project 3 Connected Office Web App
1. Use of 3 Interfaces (Each for the 3 entities*)
2. Use of Repository Classes (Each for the the 3 entities*
3. Transferring data access operation from the controller to the Repository classes
4. Manipulating the 3 entities'* controllers to access their method info through the use of interfaces to the repository classes
5. Dependency injection on startup.cs for interface and repository class services.

*Entities: Devices, Zones, Categories
