package bll

// 蘑菇球

import (
	"battleservice/src/services/base/ape"
	"battleservice/src/services/base/util"
	"battleservice/src/services/battle/conf"
	"battleservice/src/services/battle/scene/interfaces"
	"fmt"

	"github.com/cihub/seelog"
)

// FeedInitData feed初始化数据
type FeedInitData struct {
	Scene      IScene
	TypeID     uint16
	ID         uint64
	X, Y       float64
	BirthPoint interfaces.IBirthPoint
}

//BallFeed 动态障碍物
type BallFeed struct {
	BallMove
}

// OnInit 初始化
func (feed *BallFeed) OnInit(initData interface{}) error {
	seelog.Info("BallFeed.OnInit, id:", feed.GetEntityID())

	feedInitData, ok := initData.(*FeedInitData)
	if !ok {
		return fmt.Errorf("init data error")
	}

	radius := float64(conf.ConfigMgr_GetMe().GetFoodSize(feedInitData.Scene.GetEntityID(), feedInitData.TypeID))
	ballType := conf.ConfigMgr_GetMe().GetFoodBallType(feedInitData.Scene.GetEntityID(), feedInitData.TypeID)
	feed.BallMove = BallMove{
		BallFood: BallFood{
			id:       feedInitData.ID,
			typeID:   feedInitData.TypeID,
			BallType: ballType,
			Pos:      util.Vector2{float64(feedInitData.X), float64(feedInitData.Y)},
			radius:   float64(radius),
		},
		PhysicObj: ape.NewCircleParticle(float32(feedInitData.X), float32(feedInitData.Y), float32(radius)),
	}

	feed.SetBirthPoint(feedInitData.BirthPoint)
	feed.ResetRect()
	feed.PhysicObj.SetFixed(true)
	feedInitData.Scene.AddFeedPhysic(feed.PhysicObj)

	return nil
}

// OnLoop 每帧调用
func (feed *BallFeed) OnLoop() {
	seelog.Debug("BallFeed.OnLoop")
}

// OnDestroy 销毁
func (feed *BallFeed) OnDestroy() {
	seelog.Debug("BallFeed.OnDestroy")
}