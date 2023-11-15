/*
 * For a detailed explanation regarding each configuration property, visit:
 * https://jestjs.io/docs/configuration
 */

module.exports = {
    setupFilesAfterEnv: ['./jest.setup.js'],
    preset: "ts-jest/presets/js-with-ts-esm",
    testMatch: ["**/*.test.ts", "**/*.test.tsx"],
    testEnvironment: "jsdom",
};
