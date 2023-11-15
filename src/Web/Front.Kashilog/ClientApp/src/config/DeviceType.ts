export enum DeviceType {
    Pc = "Pc",
    Smartphone = "Smartphone"
}

export const conevrtToDeviceType = (value: string): DeviceType => {
    switch (value) {
        case DeviceType.Pc:
            return DeviceType.Pc;
        case DeviceType.Smartphone:
            return DeviceType.Smartphone;
        default:
            return DeviceType.Pc;
    }
}
