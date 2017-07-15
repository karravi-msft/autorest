/*
 * Code generated by Microsoft (R) AutoRest Code Generator 1.2.1.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * The access keys for the storage account.
 *
 */
class StorageAccountKeys {
  /**
   * Create a StorageAccountKeys.
   * @member {string} [key1] Gets the value of key 1.
   * @member {string} [key2] Gets the value of key 2.
   */
  constructor() {
  }

  /**
   * Defines the metadata of StorageAccountKeys
   *
   * @returns {object} metadata of StorageAccountKeys
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'StorageAccountKeys',
      type: {
        name: 'Composite',
        className: 'StorageAccountKeys',
        modelProperties: {
          key1: {
            required: false,
            serializedName: 'key1',
            type: {
              name: 'String'
            }
          },
          key2: {
            required: false,
            serializedName: 'key2',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = StorageAccountKeys;
