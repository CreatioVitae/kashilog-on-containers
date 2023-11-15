export class Taste {
    name: string;
    value: number;

    constructor(name: string, value: number) {
        this.name = name;
        this.value = value;
    }

    public static validateAndGetAvailableValues(targets: any): { validateResult: boolean, tastes: Array<Taste> | null } {
        if (!(targets.length > 0 &&
            Object.hasOwn(targets[0], 'tasteName') &&
            Object.hasOwn(targets[0], 'value')
        )) {
            return { validateResult: false, tastes: null };
        }

        
        if (
            targets.filter((target: { value: string; }) => { return isNaN(Number.parseInt(target.value)) }).length > 0
        ) {
            return { validateResult: false, tastes: null };
        }

        return {
            validateResult: true,
            tastes: targets.map((taste: { tasteName: string; value: number; }) => {
                return new Taste(
                    taste.tasteName,
                    taste.value
                );
            })
        };
    }
}
