import { DeviceType, conevrtToDeviceType } from "./DeviceType";

export default class GlobalSettings {
    constructor() { }

    get apiUrl() {
        const apiUrl = document.getElementById("api-url")?.dataset.apiUrl;

        // Memo: undefinedの場合にnullを返すために判別をしている
        return apiUrl == null ? null : apiUrl;
    }

    get deviceType() {
        const deviceType = document.getElementById("device-type")?.dataset.deviceType;

        return deviceType == null ? null : conevrtToDeviceType(deviceType);
    }

    get isSmartPhone() {
        return this.deviceType == DeviceType.Smartphone;
    }
}
