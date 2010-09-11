﻿namespace L2Script.Packets
{
    public class PacketList
    {
        public static string EnterWorld = "11 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C9 BC F2 A7 66 5A 0B 98 36 A5 BD 89 ED 7F E4 D7 6B 49 E2 9F EF 76 EB CE A3 FA F4 BF 0C 64 A3 B4 A4 CE DC C6 08 3E 6E EA 45 CA D3 FE 88 13 87 B8 06 2C 96 F0 9B 1E 8E BC C6 9B 98 C8 63 16 CF D0 BE 18 00 00 C0 A8 01 43 C0 A8 01 FE D9 29 BF 7A D9 2F 29 A1 D9 2F 29 45";
        public enum Server : byte
        {
            Die = 0x00,
            Revive = 0x01,
            AttackOutofRange = 0x02,
            AttackinCoolTime = 0x03,
            AttackDeadTarget = 0x04,
            SpawnItem = 0x05,
            SellList = 0x06,
            BuyList = 0x07,
            DeleteObject = 0x08,
            CharacterSelectionInfo = 0x09,
            LoginFail = 0x0A,
            CharacterSelectedPacket = 0x0B,
            NpcInfo = 0x0C,
            NewCharacterSuccess = 0x0D,
            NewCharacterFail = 0x0E,
            CharCreateOk = 0x0F,
            CharCreateFail = 0x10,
            ItemList = 0x11,
            SunRise = 0x12,
            SunSet = 0x13,
            TradeStartPacket = 0x14,
            TradeStartOkPacket = 0x15,
            DropItem = 0x16,
            GetItem = 0x17,
            StatusUpdate = 0x18,
            NpcHtmlMessage = 0x19,
            TradeOwnAddPacket = 0x1A,
            TradeOtherAddPacket = 0x1B,
            TradeDonePacket = 0x1C,
            CharacterDeleteSuccess = 0x1D,
            CharacterDeleteFail = 0x1E,
            ActionFail = 0x1F,
            ServerClose = 0x20,
            InventoryUpdatePacket = 0x21,
            TeleportToLocationPacket = 0x22,
            TargetSelectedPacket = 0x23,
            TargetUnselectedPacket = 0x24,
            AutoAttackStartPacket = 0x25,
            AutoAttackStopPacket = 0x26,
            SocialActionPacket = 0x27,
            ChangeMoveTypePacket = 0x28,
            ChangeWaitTypePacket = 0x29,
            ManagePledgePowerPacket = 0x2A,
            CreatePledgePacket = 0x2B,
            AskJoinPledgePacket = 0x2C,
            JoinPledgePacket = 0x2D,
            VersionCheck = 0x2E,
            MoveToLocation = 0x2F,
            NcpSay = 0x30,
            CharInfo = 0x31,
            UserInfo = 0x32,
            Attack = 0x33,
            WithdrawalPledgePacket = 0x34,
            OustPledgeMemberPacket = 0x35,
            SetOustPledgeMemberPacket = 0x36,
            DismissPledgePacket = 0x37,
            SetDismissPledgePacket = 0x38,
            AskJoinPartyPacket = 0x39,
            JoinPartyPacket = 0x3A,
            WithdrawalPartyPacket = 0x3B,
            OustPartyMemberPacket = 0x3C,
            SetOustPartyMemberPacket = 0x3D,
            DismissPartyPacket = 0x3E,
            SetDismissPartyPacket = 0x3F,
            MagicAndSkillList = 0x40,
            WareHouseDepositListPacket = 0x41,
            WareHouseWithdrawListPacket = 0x42,
            WareHouseDonePacket = 0x43,
            ShortCutRegisterPacket = 0x44,
            ShortCutInitPacket = 0x45,
            ShortCutDeletePacket = 0x46,
            StopMove = 0x47,
            MagicSkillUse = 0x48,
            MagicSkillCanceled = 0x49,
            CreatureSay = 0x4A,
            EquipUpdatePacket = 0x4B,
            DoorInfo = 0x4C,
            DoorStatusUpdate = 0x4D,
            PartySmallWindowAll = 0x4E,
            PartySmallWindowAddPacket = 0x4F,
            PartySmallWindowDeleteAllPacket = 0x50,
            PartySmallWindowDeletePacket = 0x51,
            PartySmallWindowUpdatePacket = 0x52,
            TradePressOwnOkPacket = 0x53,
            MagicSkillLaunchedPacket = 0x54,
            FriendAddRequestResult = 0x55,
            FriendAdd = 0x56,
            FriendRemove = 0x57,
            FriendList = 0x58,
            FriendStatus = 0x59,
            PledgeShowMemberListAllPacket = 0x5A,
            PledgeShowMemberListUpdatePacket = 0x5B,
            PledgeShowMemberListAddPacket = 0x5C,
            PledgeShowMemberListDeletePacket = 0x5D,
            MagicListPacket = 0x5E,
            SkillListPacket = 0x5F,
            OnVehicleInfo = 0x60,
            FinishRotating = 0x61,
            SystemMessagePacket = 0x62,
            StartPledgeWarPacket = 0x63,
            ReplyStartPledgeWarPacket = 0x64,
            StopPledgeWarPacket = 0x65,
            ReplyStopPledgeWarPacket = 0x66,
            SurrenderPledgeWarPacket = 0x67,
            ReplySurrenderPledgeWarPacket = 0x68,
            SetPledgeCrestPacket = 0x69,
            PledgeCrest = 0x6A,
            SetupGaugePacket = 0x6B,
            OnVehicleDeparture = 0x6C,
            OnVehicleCheckLocation = 0x6D,
            OnGetOnVehicle = 0x6E,
            OnGetOffVehicle = 0x6F,
            TradeRequestPacket = 0x70,
            RestartResponsePacket = 0x71,
            MoveToPawn = 0x72,
            SSQInfoPacket = 0x73,
            GameGuardQueryPacket = 0x74,
            L2FriendListPacket = 0x75,
            L2FriendPacket = 0x76,
            L2FriendStatusPacket = 0x77,
            L2FriendSayPacket = 0x78,
            ValidateLocation = 0x79,
            StartRotating = 0x7A,
            ShowBoardPacket = 0x7B,
            ChooseInventoryItemPacket = 0x7C,
            Dummy = 0x7D,
            MoveToLocationInVehicle = 0x7E,
            StopMoveInVehicle = 0x7F,
            ValidateLocationInVehicle = 0x80,
            TradeUpdatePacket = 0x81,
            TradePressOtherOkPacket = 0x82,
            //FriendAddRequestResult = 0x83,
            LeaveWorld = 0x84,
            AbnormalStatusUpdatePacket = 0x85,
            QuestListPacket = 0x86,
            EnchantResultPacket = 0x87,
            PledgeShowMemberListDeleteAllPacket = 0x88,
            PledgeInfo = 0x89,
            PledgeExtendedInfoPacket = 0x8A,
            SurrenderPersonallyPacket = 0x8B,
            Ride = 0x8C,
            //Dummy = 0x8D,
            PledgeShowInfoUpdatePacket = 0x8E,
            //ActionFail = 0x8F,
            AcquireSkillListPacket = 0x90,
            AcquireSkillInfoPacket = 0x91,
            ServerObjectInfoPacket = 0x92,
            GMHidePacket = 0x93,
            AcquireSkillDonePacket = 0x94,
            GMViewCharacterInfoPacket = 0x95,
            GMViewPledgeInfoPacket = 0x96,
            GMViewSkillInfoPacket = 0x97,
            GMViewMagicInfoPacket = 0x98,
            GMViewQuestInfoPacket = 0x99,
            GMViewItemListPacket = 0x9A,
            GMViewWarehouseWithdrawListPacket = 0x9B,
            ListPartyWatingPacket = 0x9C,
            PartyRoomInfoPacket = 0x9D,
            PlaySoundPacket = 0x9E,
            StaticObjectPacket = 0x9F,
            PrivateSellList = 0xA0,
            PrivateBuyList = 0xA1,
            PrivateStoreMsg = 0xA2,
            ShowMinimapPacket = 0xA3,
            ReviveRequestPacket = 0xA4,
            AbnormalVisualEffectPacket = 0xA5,
            TutorialShowHtml = 0xA6,
            TutorialShowQuestionMarkPacket = 0xA7,
            TutorialEnableClientEventPacket = 0xA8,
            TutorialCloseHtmlPacket = 0xA9,
            ShowRadarPacket = 0xAA,
            WithdrawAlliancePacket = 0xAB,
            OustAllianceMemberPledgePacket = 0xAC,
            DismissAlliancePacket = 0xAD,
            SetAllianceCrestPacket = 0xAE,
            AllianceCrest = 0xAF,
            ServerCloseSocketPacket = 0xB0,
            PetStatusShow = 0xB1,
            PetInfo = 0xB2,
            PetItemList = 0xB3,
            PetInventoryUpdatePacket = 0xB4,
            AllianceInfoPacket = 0xB5,
            PetStatusUpdatePacket = 0xB6,
            PetDeletePacket = 0xB7,
            DeleteRadarPacket = 0xB8,
            MyTargetSelectedPacket = 0xB9,
            PartyMemberPosition = 0xBA,
            AskJoinAlliancePacket = 0xBB,
            JoinAlliancePacket = 0xBC,
            //PrivateSellList = 0xBD,
            //PrivateBuyList = 0xBE,
            PrivateStoreBuyMsg = 0xBF,
            VehicleStartPacket = 0xC0,
            RequestTimeCheckPacket = 0xC1,
            StartAllianceWarPacket = 0xC2,
            ReplyStartAllianceWarPacket = 0xC3,
            StopAllianceWarPacket = 0xC4,
            ReplyStopAllianceWarPacket = 0xC5,
            SurrenderAllianceWarPacket = 0xC6,
            SkillCoolTimePacket = 0xC7,
            PackageToListPacket = 0xC8,
            CastleSiegeInfoPacket = 0xC9,
            CastleSiegeAttackerList = 0xCA,
            CastleSiegeDefenderList = 0xCB,
            NickNameChanged = 0xCC,
            PledgeStatusChanged = 0xCD,
            RelationChanged = 0xCE,
            OnEventTrigger = 0xCF,
            MultiSellListPacket = 0xD0,
            SetSummonRemainTimePacket = 0xD1,
            PackageSendableListPacket = 0xD2,
            EarthQuake = 0xD3,
            FlyToLocation = 0xD4,
            BlockListPacket = 0xD5,
            SpecialCamera = 0xD6,
            NormalCamera = 0xD7,
            OnSkillRemainSec = 0xD8,
            NetPingPacket = 0xD9,
            DicePacket = 0xDA,
            SnoopPacket = 0xDB,
            RecipeBookItemListPacket = 0xDC,
            RecipeItemMakeInfoPacket = 0xDD,
            RecipeShopManageListPacket = 0xDE,
            RecipeShopSellListPacket = 0xDF,
            RecipeShopItemInfoPacket = 0xE0,
            RecipeShopMsgPacket = 0xE1,
            ShowCalcPacket = 0xE2,
            RaceMonsterStatusUpdatePacket = 0xE3,
            HennaItemInfo = 0xE4,
            HennaInfoPacket = 0xE5,
            HennaUnequipListPacket = 0xE6,
            HennaUnequipItemInfo = 0xE7,
            MacroListPacket = 0xE8,
            BuyListSeed = 0xE9,
            ShowTownMapPacket = 0xEA,
            ObserverStartPacket = 0xEB,
            ObserverEndPacket = 0xEC,
            ChairSitPacket = 0xED,
            HennaEquipListPacket = 0xEE,
            SellListProcure = 0xEF,
            GMHennaInfoPacket = 0xF0,
            //ShowRadarPacket = 0xF1,
            ClientSetTimePacket = 0xF2,
            ConfirmDlgPacket = 0xF3,
            PartySpelled = 0xF4,
            PreviewList = 0xF5,
            ShopPreviewInfoPacket = 0xF6,
            CameraModePacket = 0xF7,
            ShowXMasSealPacket = 0xF8,
            EtcStatusUpdatePacket = 0xF9,
            ShortBuffStatusUpdatePacket = 0xFA,
            SSQStatusPacket = 0xFB,
            PetitionVotePacket = 0xFC,
            AgitDecoInfoPacket = 0xFD,
            DummyPacket = 0xFE,
        }
        public enum Client : byte
        {
            Logout = 0x00,
            Attack = 0x01,
            RequestStartPledgeWar = 0x03,
            RequestReplyStartPledgeWar = 0x04,
            RequestStopPledgeWar = 0x05,
            RequestSCCheck = 0x06,
            RequestSurrenderPledgeWar = 0x07,
            RequestReplySurrenderPledgeWar = 0x08,
            RequestSetPledgeCrest = 0x09,
            RequestGiveNickName = 0x0b,
            NewCharacter = 0x0c,
            CharacterDeletePacket = 0x0d,
            ProtocolVersion = 0x0e,
            MoveBackwardToLocation = 0x0f,
            Say = 0x10,
            EnterWorld = 0x11,
            CharacterSelect = 0x12,
            NewCharacterPacket = 0x13,
            ItemList = 0x14,
            RequestEquipItem = 0x15,
            RequestUnEquipItem = 0x16,
            RequestDropItemPacket = 0x17,
            UseItemPacket = 0x19,
            TradeRequestPacket = 0x1a,
            AddTradeItemPacket = 0x1b,
            TradeDonePacket = 0x1c,
            Action = 0x1f,
            RequestLinkHtml = 0x22,
            RequestBypassToServer = 0x23,
            RequestBBSWrite = 0x24,
            RequestCreatePledge = 0x25,
            RequestJoinPledge = 0x26,
            RequestAnswerJoinPledge = 0x27,
            RequestWithDrawalPledge = 0x28,
            RequestOustPledgeMember = 0x29,
            AuthLogin = 0x2b,
            RequestGetItemFromPet = 0x2c,
            RequestAllyInfo = 0x2e,
            RequestCrystallizeItem = 0x2f,
            RequestPrivateStoreManageSell = 0x30,
            SetPrivateStoreList = 0x31,
            AttackRequest = 0x32,
            RequestTeleportPacket = 0x33,
            SocialAction = 0x34,
            ChangeMoveType = 0x35,
            ChangeWaitType = 0x36,
            RequestSellItem = 0x37,
            RequestMagicSkillList = 0x38,
            RequestMagicSkillUse = 0x39,
            SendApperingPacket = 0x3a,
            SendWareHouseDepositList = 0x3b,
            SendWareHouseWithDrawList = 0x3c,
            RequestShortCutReg = 0x3d,
            RequestShortCutUse = 0x3e,
            RequestShortCutDel = 0x3f,
            RequestBuyItem = 0x40,
            RequestDismissPledge = 0x41,
            RequestJoinParty = 0x42,
            RequestAnswerJoinParty = 0x43,
            RequestWithDrawalParty = 0x44,
            RequestOustPartyMember = 0x45,
            RequestDismissParty = 0x46,
            CanNotMoveAnymore = 0x47,
            RequestTargetCancel = 0x48,
            Say2 = 0x49,
            RequestPledgeMemberList = 0x4d,
            RequestMagicList = 0x4f,
            RequestSkillList = 0x50,
            MoveWithDelta = 0x52,
            GetOnVehicle = 0x53,
            GetOffVehicle = 0x54,
            AnswerTradeRequest = 0x55,
            RequestActionUse = 0x56,
            RequestRestart = 0x57,
            RequestSiegeInfo = 0x58,
            ValidatePosition = 0x59,
            RequestSEKCustom = 0x5a,
            StartRotating = 0x5b,
            FinishRotating = 0x5c,
            RequestShowboard = 0x5e,
            RequestEnchantItem = 0x5f,
            RequestDestroyItem = 0x60,
            RequestQuestList = 0x62,
            RequestDestroyQuest = 0x63,
            RequestPledgeInfo = 0x65,
            RequestPledgeExtendedInfo = 0x66,
            RequestPledgeCrest = 0x67,
            RequestSendL2FriendSay = 0x6b,
            RequestOpenMinimap = 0x6c,
            RequestSendMsnChatLog = 0x6d,
            RequestReload = 0x6e,
            RequestHennaEquip = 0x6f,
            RequestHennaUnequipList = 0x70,
            RequestHennaUnequipInfo = 0x71,
            RequestHennaUnequip = 0x72,
            RequestAcquireSkillInfo = 0x73,
            SendBypassBuildCmd = 0x74,
            MoveToLocationInVehicle = 0x75,
            CanNotMoveAnymoreVehicle = 0x76,
            RequestFriendInvite = 0x77,
            RequestFriendAddReply = 0x78,
            RequestFriendList = 0x79,
            RequestFriendDel = 0x7a,
            CharacterRestorePacket = 0x7b,
            RequestAcquireSkill = 0x7c,
            RequestRestartPoint = 0x7d,
            RequestGMCommand = 0x7e,
            RequestPartyMatchConfig = 0x7f,
            RequestPartyMatchList = 0x80,
            RequestPartyMatchDetail = 0x81,
            SendPrivateStoreBuyList = 0x83,
            ReviveReply = 0x84,
            RequestTutorialLinkHtml = 0x85,
            RequestTutorialPassCmdToServer = 0x86,
            RequestTutorialQuestionMarkPressed = 0x87,
            RequestTutorialClientEvent = 0x88,
            RequestPetition = 0x89,
            RequestPetitionCancel = 0x8a,
            RequestGMList = 0x8b,
            RequestJoinAlly = 0x8c,
            RequestAnswerJoinAlly = 0x8d,
            RequestWithdrawAlly = 0x8e,
            RequestOustAlly = 0x8f,
            RequestDismissAlly = 0x90,
            RequestSetAllyCrest = 0x91,
            RequestAllyCrest = 0x92,
            RequestChangePetName = 0x93,
            RequestPetUseItem = 0x94,
            RequestGiveItemToPet = 0x95,
            RequestPrivateStoreQuitSell = 0x96,
            SetPrivateStoreMsgSell = 0x97,
            RequestPetGetItem = 0x98,
            RequestPrivateStoreBuyManage = 0x99,
            //SetPrivateStoreList = 0x9a,
            RequestPrivateStoreQuitBuy = 0x9c,
            SetPrivateStoreMsgBuy = 0x9d,
            //SendPrivateStoreBuyList = 0x9f,
            SendTimeCheckPacket = 0xa0,
            RequestSkillCoolTime = 0xa6,
            RequestPackageSendableItemList = 0xa7,
            RequestPackageSend = 0xa8,
            RequestBlock = 0xa9,
            RequestCastleSiegeInfo = 0xaa,
            RequestCastleSiegeAttackerList = 0xab,
            //RequestCastleSiegeInfo = 0xac,
            RequestJoinCastleSiege = 0xad,
            RequestConfirmCastleSiegeWaitingList = 0xae,
            RequestSetCastleSiegeTime = 0xaf,
            RequestMultiSellChoose = 0xb0,
            NetPing = 0xb1,
            RequestRemainTime = 0xb2,
            BypassUserCmd = 0xb3,
            Snoop = 0xb4,
            RequestRecipeBookOpen = 0xb5,
            RequestRecipeItemDelete = 0xb6,
            RequestRecipeItemMakeInfo = 0xb7,
            RequestRecipeItemMakeSelf = 0xb8,
            RequestRecipeShopManageList = 0xb9,
            RequestRecipeShopMessageSet = 0xba,
            RequestRecipeShopListSet = 0xbb,
            RequestRecipeShopManageQuit = 0xbc,
            RequestRecipeShopManageCancel = 0xbd,
            RequestRecipeShopMakeInfo = 0xbe,
            RequestRecipeShopMakeDo = 0xbf,
            RequestRecipeShopSellList = 0xc0,
            RequestObserverEndPacket = 0xc1,
            VoteSociality = 0xc2,
            RequestHennaItemList = 0xc3,
            RequestHennaItemInfo = 0xc4,
            RequestBuySeed = 0xc5,
            ConfirmDlg = 0xc6,
            RequestPreviewItem = 0xc7,
            RequestSSQStatus = 0xc8,
            PetitionVote = 0xc9,
            ReplyGameGuardQuery = 0xcb,
            RequestPledgePower = 0xcc,
            RequestMakeMacro = 0xcd,
            RequestDeleteMacro = 0xce,
            RequestProcureCrop = 0xcf,
        }
    }
}
