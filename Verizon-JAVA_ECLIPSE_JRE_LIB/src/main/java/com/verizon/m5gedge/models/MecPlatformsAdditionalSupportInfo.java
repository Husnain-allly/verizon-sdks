/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for MecPlatformsAdditionalSupportInfo type.
 */
public class MecPlatformsAdditionalSupportInfo {
    private String type;
    private MecPlatformsAdditionalSupportInfoData data;

    /**
     * Default constructor.
     */
    public MecPlatformsAdditionalSupportInfo() {
    }

    /**
     * Initialization constructor.
     * @param  type  String value for type.
     * @param  data  MecPlatformsAdditionalSupportInfoData value for data.
     */
    public MecPlatformsAdditionalSupportInfo(
            String type,
            MecPlatformsAdditionalSupportInfoData data) {
        this.type = type;
        this.data = data;
    }

    /**
     * Getter for Type.
     * Type of additional service support information for the MEC platform.
     * @return Returns the String
     */
    @JsonGetter("type")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getType() {
        return type;
    }

    /**
     * Setter for Type.
     * Type of additional service support information for the MEC platform.
     * @param type Value for String
     */
    @JsonSetter("type")
    public void setType(String type) {
        this.type = type;
    }

    /**
     * Getter for Data.
     * Data about additional service support information for the MEC platform.
     * @return Returns the MecPlatformsAdditionalSupportInfoData
     */
    @JsonGetter("data")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public MecPlatformsAdditionalSupportInfoData getData() {
        return data;
    }

    /**
     * Setter for Data.
     * Data about additional service support information for the MEC platform.
     * @param data Value for MecPlatformsAdditionalSupportInfoData
     */
    @JsonSetter("data")
    public void setData(MecPlatformsAdditionalSupportInfoData data) {
        this.data = data;
    }

    /**
     * Converts this MecPlatformsAdditionalSupportInfo into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "MecPlatformsAdditionalSupportInfo [" + "type=" + type + ", data=" + data + "]";
    }

    /**
     * Builds a new {@link MecPlatformsAdditionalSupportInfo.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link MecPlatformsAdditionalSupportInfo.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .type(getType())
                .data(getData());
        return builder;
    }

    /**
     * Class to build instances of {@link MecPlatformsAdditionalSupportInfo}.
     */
    public static class Builder {
        private String type;
        private MecPlatformsAdditionalSupportInfoData data;



        /**
         * Setter for type.
         * @param  type  String value for type.
         * @return Builder
         */
        public Builder type(String type) {
            this.type = type;
            return this;
        }

        /**
         * Setter for data.
         * @param  data  MecPlatformsAdditionalSupportInfoData value for data.
         * @return Builder
         */
        public Builder data(MecPlatformsAdditionalSupportInfoData data) {
            this.data = data;
            return this;
        }

        /**
         * Builds a new {@link MecPlatformsAdditionalSupportInfo} object using the set fields.
         * @return {@link MecPlatformsAdditionalSupportInfo}
         */
        public MecPlatformsAdditionalSupportInfo build() {
            return new MecPlatformsAdditionalSupportInfo(type, data);
        }
    }
}
