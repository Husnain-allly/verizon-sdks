/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.List;
import java.util.Map;

/**
 * This is a model class for Account type.
 */
public class Account {
    private String accountName;
    private String accountNumber;
    private String organizationName;
    private Boolean isProvisioningAllowed;
    private List<String> carriers;
    private List<String> features;
    private List<IpPool> ipPools;
    private List<ServicePlan> servicePlans;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public Account() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  accountNumber  String value for accountNumber.
     * @param  organizationName  String value for organizationName.
     * @param  isProvisioningAllowed  Boolean value for isProvisioningAllowed.
     * @param  carriers  List of String value for carriers.
     * @param  features  List of String value for features.
     * @param  ipPools  List of IpPool value for ipPools.
     * @param  servicePlans  List of ServicePlan value for servicePlans.
     */
    public Account(
            String accountName,
            String accountNumber,
            String organizationName,
            Boolean isProvisioningAllowed,
            List<String> carriers,
            List<String> features,
            List<IpPool> ipPools,
            List<ServicePlan> servicePlans) {
        this.accountName = accountName;
        this.accountNumber = accountNumber;
        this.organizationName = organizationName;
        this.isProvisioningAllowed = isProvisioningAllowed;
        this.carriers = carriers;
        this.features = features;
        this.ipPools = ipPools;
        this.servicePlans = servicePlans;
    }

    /**
     * Getter for AccountName.
     * The name of the account.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * The name of the account.
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for AccountNumber.
     * The billing number of the account.
     * @return Returns the String
     */
    @JsonGetter("accountNumber")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAccountNumber() {
        return accountNumber;
    }

    /**
     * Setter for AccountNumber.
     * The billing number of the account.
     * @param accountNumber Value for String
     */
    @JsonSetter("accountNumber")
    public void setAccountNumber(String accountNumber) {
        this.accountNumber = accountNumber;
    }

    /**
     * Getter for OrganizationName.
     * The name of the organization that the account is part of.
     * @return Returns the String
     */
    @JsonGetter("organizationName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getOrganizationName() {
        return organizationName;
    }

    /**
     * Setter for OrganizationName.
     * The name of the organization that the account is part of.
     * @param organizationName Value for String
     */
    @JsonSetter("organizationName")
    public void setOrganizationName(String organizationName) {
        this.organizationName = organizationName;
    }

    /**
     * Getter for IsProvisioningAllowed.
     * True if devices can be added to the account and activated with a single request. False if
     * devices must be added to the account before they can be activated.
     * @return Returns the Boolean
     */
    @JsonGetter("isProvisioningAllowed")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Boolean getIsProvisioningAllowed() {
        return isProvisioningAllowed;
    }

    /**
     * Setter for IsProvisioningAllowed.
     * True if devices can be added to the account and activated with a single request. False if
     * devices must be added to the account before they can be activated.
     * @param isProvisioningAllowed Value for Boolean
     */
    @JsonSetter("isProvisioningAllowed")
    public void setIsProvisioningAllowed(Boolean isProvisioningAllowed) {
        this.isProvisioningAllowed = isProvisioningAllowed;
    }

    /**
     * Getter for Carriers.
     * The names of all carriers for the account.
     * @return Returns the List of String
     */
    @JsonGetter("carriers")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<String> getCarriers() {
        return carriers;
    }

    /**
     * Setter for Carriers.
     * The names of all carriers for the account.
     * @param carriers Value for List of String
     */
    @JsonSetter("carriers")
    public void setCarriers(List<String> carriers) {
        this.carriers = carriers;
    }

    /**
     * Getter for Features.
     * The names of features that are enabled for the account.
     * @return Returns the List of String
     */
    @JsonGetter("features")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<String> getFeatures() {
        return features;
    }

    /**
     * Setter for Features.
     * The names of features that are enabled for the account.
     * @param features Value for List of String
     */
    @JsonSetter("features")
    public void setFeatures(List<String> features) {
        this.features = features;
    }

    /**
     * Getter for IpPools.
     * Array of IP pools that are available to the account.
     * @return Returns the List of IpPool
     */
    @JsonGetter("iPPools")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<IpPool> getIpPools() {
        return ipPools;
    }

    /**
     * Setter for IpPools.
     * Array of IP pools that are available to the account.
     * @param ipPools Value for List of IpPool
     */
    @JsonSetter("iPPools")
    public void setIpPools(List<IpPool> ipPools) {
        this.ipPools = ipPools;
    }

    /**
     * Getter for ServicePlans.
     * Array of service plans that are available to the account.
     * @return Returns the List of ServicePlan
     */
    @JsonGetter("servicePlans")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<ServicePlan> getServicePlans() {
        return servicePlans;
    }

    /**
     * Setter for ServicePlans.
     * Array of service plans that are available to the account.
     * @param servicePlans Value for List of ServicePlan
     */
    @JsonSetter("servicePlans")
    public void setServicePlans(List<ServicePlan> servicePlans) {
        this.servicePlans = servicePlans;
    }

    /**
     * Hidden method for the serialization of additional properties.
     * @return The map of additionally set properties.
     */
    @JsonAnyGetter
    private Map<String, Object> getAdditionalProperties() {
        return additionalProperties.getAdditionalProperties();
    }

    /**
     * Hidden method for the de-serialization of additional properties.
     * @param name The name of the additional property.
     * @param value The Object value of the additional property.
     */
    @JsonAnySetter
    private void setAdditionalProperties(String name, Object value) {
        additionalProperties.setAdditionalProperty(name,
                ConversionHelper.convertToSimpleType(value,
                        x -> x),
                true);
    }

    /**
     * Getter for the value of additional properties based on provided property name.
     * @param name The name of the additional property.
     * @return Either the Object property value or null if not exist.
     */
    
    public Object getAdditionalProperty(String name) {
        return additionalProperties.getAdditionalProperty(name);
    }

    /**
     * Converts this Account into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Account [" + "accountName=" + accountName + ", accountNumber=" + accountNumber
                + ", organizationName=" + organizationName + ", isProvisioningAllowed="
                + isProvisioningAllowed + ", carriers=" + carriers + ", features=" + features
                + ", ipPools=" + ipPools + ", servicePlans=" + servicePlans
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link Account.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Account.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .accountName(getAccountName())
                .accountNumber(getAccountNumber())
                .organizationName(getOrganizationName())
                .isProvisioningAllowed(getIsProvisioningAllowed())
                .carriers(getCarriers())
                .features(getFeatures())
                .ipPools(getIpPools())
                .servicePlans(getServicePlans());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link Account}.
     */
    public static class Builder {
        private String accountName;
        private String accountNumber;
        private String organizationName;
        private Boolean isProvisioningAllowed;
        private List<String> carriers;
        private List<String> features;
        private List<IpPool> ipPools;
        private List<ServicePlan> servicePlans;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for accountName.
         * @param  accountName  String value for accountName.
         * @return Builder
         */
        public Builder accountName(String accountName) {
            this.accountName = accountName;
            return this;
        }

        /**
         * Setter for accountNumber.
         * @param  accountNumber  String value for accountNumber.
         * @return Builder
         */
        public Builder accountNumber(String accountNumber) {
            this.accountNumber = accountNumber;
            return this;
        }

        /**
         * Setter for organizationName.
         * @param  organizationName  String value for organizationName.
         * @return Builder
         */
        public Builder organizationName(String organizationName) {
            this.organizationName = organizationName;
            return this;
        }

        /**
         * Setter for isProvisioningAllowed.
         * @param  isProvisioningAllowed  Boolean value for isProvisioningAllowed.
         * @return Builder
         */
        public Builder isProvisioningAllowed(Boolean isProvisioningAllowed) {
            this.isProvisioningAllowed = isProvisioningAllowed;
            return this;
        }

        /**
         * Setter for carriers.
         * @param  carriers  List of String value for carriers.
         * @return Builder
         */
        public Builder carriers(List<String> carriers) {
            this.carriers = carriers;
            return this;
        }

        /**
         * Setter for features.
         * @param  features  List of String value for features.
         * @return Builder
         */
        public Builder features(List<String> features) {
            this.features = features;
            return this;
        }

        /**
         * Setter for ipPools.
         * @param  ipPools  List of IpPool value for ipPools.
         * @return Builder
         */
        public Builder ipPools(List<IpPool> ipPools) {
            this.ipPools = ipPools;
            return this;
        }

        /**
         * Setter for servicePlans.
         * @param  servicePlans  List of ServicePlan value for servicePlans.
         * @return Builder
         */
        public Builder servicePlans(List<ServicePlan> servicePlans) {
            this.servicePlans = servicePlans;
            return this;
        }

        /**
         * Setter for additional property that are not in model fields.
         * @param name The name of the additional property.
         * @param value The Object value of the additional property.
         * @return Builder.
         */
        public Builder additionalProperty(String name, Object value) {
            this.additionalProperties.setAdditionalProperty(name, value);
            return this;
        }

        /**
         * Builds a new {@link Account} object using the set fields.
         * @return {@link Account}
         */
        public Account build() {
            Account model =
                    new Account(accountName, accountNumber, organizationName, isProvisioningAllowed,
                            carriers, features, ipPools, servicePlans);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
