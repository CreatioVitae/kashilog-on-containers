export class Texture {
    name: string;
    value: number;

    constructor(name: string, value: number) {
        this.name = name;
        this.value = value;
    }

    public static validateAndGetAvailableValues(targets: any): { validateResult: boolean, textures: Array<Texture> | null } {
        if (!(targets.length > 0 &&
            Object.hasOwn(targets[0], 'textureName') &&
            Object.hasOwn(targets[0], 'value')
        )) {
            return { validateResult: false, textures: null };
        }

        if (
            targets.filter((target: { value: string; }) => { return isNaN(Number.parseInt(target.value)) }).length > 0
        ) {
            return { validateResult: false, textures: null };
        }

        return {
            validateResult: true,
            textures: targets.map((taste: { textureName: string; value: number; }) => {
                return new Texture(
                    taste.textureName,
                    taste.value
                );
            })
        };
    }
}
