/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;
import java.util.List;

/**
 * This is a model class for DtoUpdateNotificationGroupRequest type.
 */
public class DtoUpdateNotificationGroupRequest {
    private String accountname;
    private DtoNotificationGroupRequestEntity group;
    private String id;
    private List<String> userids;

    /**
     * Default constructor.
     */
    public DtoUpdateNotificationGroupRequest() {
    }

    /**
     * Initialization constructor.
     * @param  group  DtoNotificationGroupRequestEntity value for group.
     * @param  accountname  String value for accountname.
     * @param  id  String value for id.
     * @param  userids  List of String value for userids.
     */
    public DtoUpdateNotificationGroupRequest(
            DtoNotificationGroupRequestEntity group,
            String accountname,
            String id,
            List<String> userids) {
        this.accountname = accountname;
        this.group = group;
        this.id = id;
        this.userids = userids;
    }

    /**
     * Getter for Accountname.
     * The numeric account name, which must include leading zeros
     * @return Returns the String
     */
    @JsonGetter("accountname")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAccountname() {
        return accountname;
    }

    /**
     * Setter for Accountname.
     * The numeric account name, which must include leading zeros
     * @param accountname Value for String
     */
    @JsonSetter("accountname")
    public void setAccountname(String accountname) {
        this.accountname = accountname;
    }

    /**
     * Getter for Group.
     * @return Returns the DtoNotificationGroupRequestEntity
     */
    @JsonGetter("group")
    public DtoNotificationGroupRequestEntity getGroup() {
        return group;
    }

    /**
     * Setter for Group.
     * @param group Value for DtoNotificationGroupRequestEntity
     */
    @JsonSetter("group")
    public void setGroup(DtoNotificationGroupRequestEntity group) {
        this.group = group;
    }

    /**
     * Getter for Id.
     * UUID of the user record, assigned at creation
     * @return Returns the String
     */
    @JsonGetter("id")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getId() {
        return id;
    }

    /**
     * Setter for Id.
     * UUID of the user record, assigned at creation
     * @param id Value for String
     */
    @JsonSetter("id")
    public void setId(String id) {
        this.id = id;
    }

    /**
     * Getter for Userids.
     * @return Returns the List of String
     */
    @JsonGetter("userids")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<String> getUserids() {
        return userids;
    }

    /**
     * Setter for Userids.
     * @param userids Value for List of String
     */
    @JsonSetter("userids")
    public void setUserids(List<String> userids) {
        this.userids = userids;
    }

    /**
     * Converts this DtoUpdateNotificationGroupRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DtoUpdateNotificationGroupRequest [" + "group=" + group + ", accountname="
                + accountname + ", id=" + id + ", userids=" + userids + "]";
    }

    /**
     * Builds a new {@link DtoUpdateNotificationGroupRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DtoUpdateNotificationGroupRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(group)
                .accountname(getAccountname())
                .id(getId())
                .userids(getUserids());
        return builder;
    }

    /**
     * Class to build instances of {@link DtoUpdateNotificationGroupRequest}.
     */
    public static class Builder {
        private DtoNotificationGroupRequestEntity group;
        private String accountname;
        private String id;
        private List<String> userids;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  group  DtoNotificationGroupRequestEntity value for group.
         */
        public Builder(DtoNotificationGroupRequestEntity group) {
            this.group = group;
        }

        /**
         * Setter for group.
         * @param  group  DtoNotificationGroupRequestEntity value for group.
         * @return Builder
         */
        public Builder group(DtoNotificationGroupRequestEntity group) {
            this.group = group;
            return this;
        }

        /**
         * Setter for accountname.
         * @param  accountname  String value for accountname.
         * @return Builder
         */
        public Builder accountname(String accountname) {
            this.accountname = accountname;
            return this;
        }

        /**
         * Setter for id.
         * @param  id  String value for id.
         * @return Builder
         */
        public Builder id(String id) {
            this.id = id;
            return this;
        }

        /**
         * Setter for userids.
         * @param  userids  List of String value for userids.
         * @return Builder
         */
        public Builder userids(List<String> userids) {
            this.userids = userids;
            return this;
        }

        /**
         * Builds a new {@link DtoUpdateNotificationGroupRequest} object using the set fields.
         * @return {@link DtoUpdateNotificationGroupRequest}
         */
        public DtoUpdateNotificationGroupRequest build() {
            return new DtoUpdateNotificationGroupRequest(group, accountname, id, userids);
        }
    }
}
